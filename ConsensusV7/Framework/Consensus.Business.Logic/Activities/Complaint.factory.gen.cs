using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ComplaintModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalComplaintFactory : LocalFactory<LocalComplaintModel, ComplaintRecord, String>, IComplaintFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ComplaintModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ComplaintModel' /> instance.
        /// </returns>
        public LocalComplaintModel Create()
        {
            return new LocalComplaintModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ComplaintModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ComplaintModel' /> instances.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAll()
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAll();
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ComplaintModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ComplaintModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalComplaintModel FetchById(String id)
        {
            ComplaintRecord record = this.Provider.DataProvider.Activities.Complaint.FetchById(id);
            if (record == null)
                return null;
            return new LocalComplaintModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Complaint/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.Complaint.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ComplaintModel' /> instances.
        /// </summary>
        /// <param name="fromProleIdId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instances that match the specified <paramref name='fromProleIdId' />.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAllByFromProleIdId(String fromProleIdId)
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAllByFromProleId(fromProleIdId);
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ComplaintModel' /> instances.
        /// </summary>
        /// <param name="reProleIdId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instances that match the specified <paramref name='reProleIdId' />.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAllByReProleIdId(String reProleIdId)
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAllByReProleId(reProleIdId);
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ComplaintModel' /> instances.
        /// </summary>
        /// <param name="mgrProleIdId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instances that match the specified <paramref name='mgrProleIdId' />.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAllByMgrProleIdId(String mgrProleIdId)
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAllByMgrProleId(mgrProleIdId);
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ComplaintModel' /> instances.
        /// </summary>
        /// <param name="medtrProleIdId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instances that match the specified <paramref name='medtrProleIdId' />.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAllByMedtrProleIdId(String medtrProleIdId)
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAllByMedtrProleId(medtrProleIdId);
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ComplaintModel' /> instances.
        /// </summary>
        /// <param name="promotionIDId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instances that match the specified <paramref name='promotionIDId' />.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAllByPromotionIDId(String promotionIDId)
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAllByPmId(promotionIDId);
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ComplaintModel' /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ComplaintModel' /> instances that match the specified <paramref name='detailsIdId' />.
        /// </returns>
        public IEnumerable<LocalComplaintModel> FetchAllByDetailsIdId(String detailsIdId)
        {
            IEnumerable<ComplaintRecord> recordCollection = this.Provider.DataProvider.Activities.Complaint.FetchAllByDetailsId(detailsIdId);
            foreach (ComplaintRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalComplaintModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ComplaintModel" /> instance.
        /// </returns>
        Consensus.Activities.IComplaintModel IComplaintFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ComplaintModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ComplaintModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ComplaintModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IComplaintModel IComplaintFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IComplaintFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="fromProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="fromProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAllByFromProleIdId(System.String fromProleIdId)
        {
            return this.FetchAllByFromProleIdId(fromProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="reProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="reProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAllByReProleIdId(System.String reProleIdId)
        {
            return this.FetchAllByReProleIdId(reProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="mgrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="mgrProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAllByMgrProleIdId(System.String mgrProleIdId)
        {
            return this.FetchAllByMgrProleIdId(mgrProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="medtrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="medtrProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAllByMedtrProleIdId(System.String medtrProleIdId)
        {
            return this.FetchAllByMedtrProleIdId(medtrProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="promotionIDId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="promotionIDId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAllByPromotionIDId(System.String promotionIDId)
        {
            return this.FetchAllByPromotionIDId(promotionIDId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> IComplaintFactory.FetchAllByDetailsIdId(System.String detailsIdId)
        {
            return this.FetchAllByDetailsIdId(detailsIdId);
        }

        #endregion
    }
}
