using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PromotionModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPromotionFactory : LocalFactory<LocalPromotionModel, PromotionRecord, String>, IPromotionFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PromotionModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PromotionModel' /> instance.
        /// </returns>
        public LocalPromotionModel Create()
        {
            return new LocalPromotionModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PromotionModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PromotionModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPromotionModel> FetchAll()
        {
            IEnumerable<PromotionRecord> recordCollection = this.Provider.DataProvider.Marketing.Promotion.FetchAll();
            foreach (PromotionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PromotionModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PromotionModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPromotionModel FetchById(String id)
        {
            PromotionRecord record = this.Provider.DataProvider.Marketing.Promotion.FetchById(id);
            if (record == null)
                return null;
            return new LocalPromotionModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Promotion/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.Promotion.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionModel' /> instances.
        /// </summary>
        /// <param name="promotionMasterId">
        ///     The value which identifies the <see cref='PromotionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionModel' /> instances that match the specified <paramref name='promotionMasterId' />.
        /// </returns>
        public IEnumerable<LocalPromotionModel> FetchAllByPromotionMasterId(String promotionMasterId)
        {
            IEnumerable<PromotionRecord> recordCollection = this.Provider.DataProvider.Marketing.Promotion.FetchAllByCmpId(promotionMasterId);
            foreach (PromotionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionModel' /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref='PromotionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionModel' /> instances that match the specified <paramref name='managerId' />.
        /// </returns>
        public IEnumerable<LocalPromotionModel> FetchAllByManagerId(String managerId)
        {
            IEnumerable<PromotionRecord> recordCollection = this.Provider.DataProvider.Marketing.Promotion.FetchAllByProleId(managerId);
            foreach (PromotionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionModel' /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref='PromotionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionModel' /> instances that match the specified <paramref name='approverId' />.
        /// </returns>
        public IEnumerable<LocalPromotionModel> FetchAllByApproverId(String approverId)
        {
            IEnumerable<PromotionRecord> recordCollection = this.Provider.DataProvider.Marketing.Promotion.FetchAllByAppProleId(approverId);
            foreach (PromotionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionModel" /> instance.
        /// </returns>
        Consensus.Marketing.IPromotionModel IPromotionFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> IPromotionFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.IPromotionModel IPromotionFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPromotionFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="promotionMasterId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="promotionMasterId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> IPromotionFactory.FetchAllByPromotionMasterId(System.String promotionMasterId)
        {
            return this.FetchAllByPromotionMasterId(promotionMasterId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> IPromotionFactory.FetchAllByManagerId(System.String managerId)
        {
            return this.FetchAllByManagerId(managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> IPromotionFactory.FetchAllByApproverId(System.String approverId)
        {
            return this.FetchAllByApproverId(approverId);
        }

        #endregion
    }
}
