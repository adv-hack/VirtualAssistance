using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PromotionMasterModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPromotionMasterFactory : LocalFactory<LocalPromotionMasterModel, PromotionMasterRecord, String>, IPromotionMasterFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PromotionMasterModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PromotionMasterModel' /> instance.
        /// </returns>
        public LocalPromotionMasterModel Create()
        {
            return new LocalPromotionMasterModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PromotionMasterModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PromotionMasterModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPromotionMasterModel> FetchAll()
        {
            IEnumerable<PromotionMasterRecord> recordCollection = this.Provider.DataProvider.Marketing.PromotionMaster.FetchAll();
            foreach (PromotionMasterRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionMasterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PromotionMasterModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PromotionMasterModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionMasterModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPromotionMasterModel FetchById(String id)
        {
            PromotionMasterRecord record = this.Provider.DataProvider.Marketing.PromotionMaster.FetchById(id);
            if (record == null)
                return null;
            return new LocalPromotionMasterModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PromotionMaster/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.PromotionMaster.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionMasterModel' /> instances.
        /// </summary>
        /// <param name="cmpIdId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionMasterModel' /> instances that match the specified <paramref name='cmpIdId' />.
        /// </returns>
        public IEnumerable<LocalPromotionMasterModel> FetchAllByCmpIdId(String cmpIdId)
        {
            IEnumerable<PromotionMasterRecord> recordCollection = this.Provider.DataProvider.Marketing.PromotionMaster.FetchAllByCmpId(cmpIdId);
            foreach (PromotionMasterRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionMasterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionMasterModel' /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionMasterModel' /> instances that match the specified <paramref name='courseIdId' />.
        /// </returns>
        public IEnumerable<LocalPromotionMasterModel> FetchAllByCourseIdId(String courseIdId)
        {
            IEnumerable<PromotionMasterRecord> recordCollection = this.Provider.DataProvider.Marketing.PromotionMaster.FetchAllByCourseId(courseIdId);
            foreach (PromotionMasterRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionMasterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionMasterModel' /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionMasterModel' /> instances that match the specified <paramref name='managerId' />.
        /// </returns>
        public IEnumerable<LocalPromotionMasterModel> FetchAllByManagerId(String managerId)
        {
            IEnumerable<PromotionMasterRecord> recordCollection = this.Provider.DataProvider.Marketing.PromotionMaster.FetchAllByProleId(managerId);
            foreach (PromotionMasterRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionMasterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PromotionMasterModel' /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PromotionMasterModel' /> instances that match the specified <paramref name='approverId' />.
        /// </returns>
        public IEnumerable<LocalPromotionMasterModel> FetchAllByApproverId(String approverId)
        {
            IEnumerable<PromotionMasterRecord> recordCollection = this.Provider.DataProvider.Marketing.PromotionMaster.FetchAllByAppProleId(approverId);
            foreach (PromotionMasterRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPromotionMasterModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionMasterModel" /> instance.
        /// </returns>
        Consensus.Marketing.IPromotionMasterModel IPromotionMasterFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionMasterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> IPromotionMasterFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionMasterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.IPromotionMasterModel IPromotionMasterFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPromotionMasterFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="cmpIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="cmpIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> IPromotionMasterFactory.FetchAllByCmpIdId(System.String cmpIdId)
        {
            return this.FetchAllByCmpIdId(cmpIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> IPromotionMasterFactory.FetchAllByCourseIdId(System.String courseIdId)
        {
            return this.FetchAllByCourseIdId(courseIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> IPromotionMasterFactory.FetchAllByManagerId(System.String managerId)
        {
            return this.FetchAllByManagerId(managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> IPromotionMasterFactory.FetchAllByApproverId(System.String approverId)
        {
            return this.FetchAllByApproverId(approverId);
        }

        #endregion
    }
}
