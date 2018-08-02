using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class BatchXref : Proxy<IBatchXrefModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Batch" /> member.
        /// </summary>
        private Consensus.Other.Batch _batch;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Link between the batch xref and batch.
        /// </summary>
        public Consensus.Other.Batch Batch
        {
            get
            {
                if (_batch == null && this.Model.Batch != null)
                    _batch = new Consensus.Other.Batch(this.Model.Batch);
                if (_batch == null)
                    _batch = Consensus.Other.Batch.Create();
                return _batch;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for Link between the batch xref and batch.
        /// </summary>
        public System.String BatchId
        {
            get { return this.Model.BatchId; }
            set { this.Model.BatchId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_TABLE_NAME" field.
        /// </summary>
        public System.String TableName
        {
            get { return this.Model.TableName; }
            set { this.Model.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_ID" field.
        /// </summary>
        public System.String LinkId
        {
            get { return this.Model.LinkId; }
            set { this.Model.LinkId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_URL" field.
        /// </summary>
        public System.String LinkUrl
        {
            get { return this.Model.LinkUrl; }
            set { this.Model.LinkUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_STATUS" field.
        /// </summary>
        public System.Byte Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal BatchXref(IBatchXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchXrefModel" /> instance.
        /// </returns>
        public static Consensus.Other.BatchXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BatchXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchXrefModel" /> instance.
        /// </returns>
        public static Consensus.Other.BatchXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IBatchXrefModel model = provider.Other.BatchXref.Create();
            return model == null ? null : new Consensus.Other.BatchXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.BatchXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BatchXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.BatchXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IBatchXrefModel> collection = provider.Other.BatchXref.FetchAll();
            return collection.Select(model => new Consensus.Other.BatchXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.BatchXref FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BatchXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.BatchXref FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IBatchXrefModel model = provider.Other.BatchXref.FetchById(id);
            return model == null ? null : new Consensus.Other.BatchXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BatchXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Other.BatchXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchXrefModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:BatchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        public static IEnumerable<Consensus.Other.BatchXref> FetchAllByBatchId(System.String batchId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BatchXref.FetchAllByBatchId(site,batchId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchXrefModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:BatchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        public static IEnumerable<Consensus.Other.BatchXref> FetchAllByBatchId(ConsensusSite site, System.String batchId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IBatchXrefModel> collection = provider.Other.BatchXref.FetchAllByBatchId(batchId);
            return collection.Select(model => new Consensus.Other.BatchXref(model));
        }

        #endregion
    }
}
