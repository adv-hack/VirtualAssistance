using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Document;

namespace Consensus.Other
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Batch : Proxy<IBatchModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BatchEcId" /> member.
        /// </summary>
        private Consensus.Other.Exportconfigurations _batchEcId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BatchDiId" /> member.
        /// </summary>
        private Consensus.Other.Dataimports _batchDiId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BatchPrintRequests" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel> _batchPrintRequests;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BatchXref" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Other.BatchXref, Consensus.Other.IBatchXrefModel> _batchXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "BAT_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_PROC" field.
        /// </summary>
        public System.String Procedure
        {
            get { return this.Model.Procedure; }
            set { this.Model.Procedure = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_STATUS" field.
        /// </summary>
        public System.String Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_COUNT" field.
        /// </summary>
        public System.Nullable<System.Int32> BatchProcessedRecords
        {
            get { return this.Model.BatchProcessedRecords; }
            set { this.Model.BatchProcessedRecords = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_START_D_T" field.
        /// </summary>
        public System.Nullable<System.DateTime> BatchStartedDate
        {
            get { return this.Model.BatchStartedDate; }
            set { this.Model.BatchStartedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_D_T" field.
        /// </summary>
        public System.Nullable<System.DateTime> BatchFinishedDate
        {
            get { return this.Model.BatchFinishedDate; }
            set { this.Model.BatchFinishedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_BY" field.
        /// </summary>
        public System.String BatchRunBy
        {
            get { return this.Model.BatchRunBy; }
            set { this.Model.BatchRunBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_NOTE" field.
        /// </summary>
        public System.String BatchNote
        {
            get { return this.Model.BatchNote; }
            set { this.Model.BatchNote = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ERROR_NOTE" field.
        /// </summary>
        public System.String BatchErrorNote
        {
            get { return this.Model.BatchErrorNote; }
            set { this.Model.BatchErrorNote = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_EXT_FLAG" field.
        /// </summary>
        public System.Nullable<System.Byte> ExternallyCompleted
        {
            get { return this.Model.ExternallyCompleted; }
            set { this.Model.ExternallyCompleted = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_DD_STATUS" field.
        /// </summary>
        public System.Nullable<System.Byte> DdStatus
        {
            get { return this.Model.DdStatus; }
            set { this.Model.DdStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_REC_ID" field.
        /// </summary>
        public System.String RecId
        {
            get { return this.Model.RecId; }
            set { this.Model.RecId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RERUN" field.
        /// </summary>
        public System.Byte Rerun
        {
            get { return this.Model.Rerun; }
            set { this.Model.Rerun = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_EC_ID" field.
        /// </summary>
        public Consensus.Other.Exportconfigurations BatchEcId
        {
            get
            {
                if (_batchEcId == null && this.Model.BatchEcId != null)
                    _batchEcId = new Consensus.Other.Exportconfigurations(this.Model.BatchEcId);
                if (_batchEcId == null)
                    _batchEcId = Consensus.Other.Exportconfigurations.Create();
                return _batchEcId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_EC_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> BatchEcIdId
        {
            get { return this.Model.BatchEcIdId; }
            set { this.Model.BatchEcIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ARG_ID" field.
        /// </summary>
        public System.String ArgId
        {
            get { return this.Model.ArgId; }
            set { this.Model.ArgId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_DI_ID" field.
        /// </summary>
        public Consensus.Other.Dataimports BatchDiId
        {
            get
            {
                if (_batchDiId == null && this.Model.BatchDiId != null)
                    _batchDiId = new Consensus.Other.Dataimports(this.Model.BatchDiId);
                if (_batchDiId == null)
                    _batchDiId = Consensus.Other.Dataimports.Create();
                return _batchDiId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_DI_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> BatchDiIdId
        {
            get { return this.Model.BatchDiIdId; }
            set { this.Model.BatchDiIdId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Document.PrintRequest> BatchPrintRequests
        {
            get
            {
                if (_batchPrintRequests == null)
                    _batchPrintRequests = new ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel>(this.Model.BatchPrintRequests, model => new Consensus.Document.PrintRequest(model));
                return _batchPrintRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchXrefModel" /> instances that reference this <see cref="!:BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Other.BatchXref> BatchXref
        {
            get
            {
                if (_batchXref == null)
                    _batchXref = new ProxyCollection<Consensus.Other.BatchXref, Consensus.Other.IBatchXrefModel>(this.Model.BatchXref, model => new Consensus.Other.BatchXref(model));
                return _batchXref;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Batch(IBatchModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchModel" /> instance.
        /// </returns>
        public static Consensus.Other.Batch Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchModel" /> instance.
        /// </returns>
        public static Consensus.Other.Batch Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IBatchModel model = provider.Other.Batch.Create();
            return model == null ? null : new Consensus.Other.Batch(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Batch> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Batch> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IBatchModel> collection = provider.Other.Batch.FetchAll();
            return collection.Select(model => new Consensus.Other.Batch(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Batch FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Batch FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IBatchModel model = provider.Other.Batch.FetchById(id);
            return model == null ? null : new Consensus.Other.Batch(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Other.Batch.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BatchModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Other.Batch> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BatchModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Other.Batch> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IBatchModel> collection = provider.Other.Batch.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Other.Batch(model));
        }

        public static IEnumerable<Consensus.Other.Batch> FetchAllByBatchEcIdId(System.Nullable<System.Int32> batchEcIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.FetchAllByBatchEcIdId(site,batchEcIdId);
        }

        public static IEnumerable<Consensus.Other.Batch> FetchAllByBatchEcIdId(ConsensusSite site, System.Nullable<System.Int32> batchEcIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IBatchModel> collection = provider.Other.Batch.FetchAllByBatchEcIdId(batchEcIdId);
            return collection.Select(model => new Consensus.Other.Batch(model));
        }

        public static IEnumerable<Consensus.Other.Batch> FetchAllByBatchDiIdId(System.Nullable<System.Int32> batchDiIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Batch.FetchAllByBatchDiIdId(site,batchDiIdId);
        }

        public static IEnumerable<Consensus.Other.Batch> FetchAllByBatchDiIdId(ConsensusSite site, System.Nullable<System.Int32> batchDiIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IBatchModel> collection = provider.Other.Batch.FetchAllByBatchDiIdId(batchDiIdId);
            return collection.Select(model => new Consensus.Other.Batch(model));
        }

        #endregion
    }
}
