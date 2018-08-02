using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class WorkflowRecType : Proxy<IWorkflowRecTypeModel, String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "WRT_REC_TYPE" field.
        /// </summary>
        public System.String RecType
        {
            get { return this.Model.RecType; }
            set { this.Model.RecType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE" field.
        /// </summary>
        public System.String Table
        {
            get { return this.Model.Table; }
            set { this.Model.Table = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE_KEY" field.
        /// </summary>
        public System.String TableKey
        {
            get { return this.Model.TableKey; }
            set { this.Model.TableKey = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SQL" field.
        /// </summary>
        public System.String Sql
        {
            get { return this.Model.Sql; }
            set { this.Model.Sql = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE" field.
        /// </summary>
        public System.String PrType
        {
            get { return this.Model.PrType; }
            set { this.Model.PrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SEARCH_ENTITY" field.
        /// </summary>
        public System.String SearchEntity
        {
            get { return this.Model.SearchEntity; }
            set { this.Model.SearchEntity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_LINK_TO" field.
        /// </summary>
        public System.String LinkTo
        {
            get { return this.Model.LinkTo; }
            set { this.Model.LinkTo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE_TYPE" field.
        /// </summary>
        public System.String PrTypeType
        {
            get { return this.Model.PrTypeType; }
            set { this.Model.PrTypeType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY" field.
        /// </summary>
        public System.Nullable<System.Byte> Query
        {
            get { return this.Model.Query; }
            set { this.Model.Query = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_SELECT" field.
        /// </summary>
        public System.String QuerySelect
        {
            get { return this.Model.QuerySelect; }
            set { this.Model.QuerySelect = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_MERGE" field.
        /// </summary>
        public System.String QueryMerge
        {
            get { return this.Model.QueryMerge; }
            set { this.Model.QueryMerge = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_ACT_TYPES" field.
        /// </summary>
        public System.String ActTypes
        {
            get { return this.Model.ActTypes; }
            set { this.Model.ActTypes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_ARG" field.
        /// </summary>
        public System.Byte PrArg
        {
            get { return this.Model.PrArg; }
            set { this.Model.PrArg = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal WorkflowRecType(IWorkflowRecTypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </returns>
        public static Consensus.Other.WorkflowRecType Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return WorkflowRecType.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </returns>
        public static Consensus.Other.WorkflowRecType Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IWorkflowRecTypeModel model = provider.Other.WorkflowRecType.Create();
            return model == null ? null : new Consensus.Other.WorkflowRecType(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowRecTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowRecTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.WorkflowRecType> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return WorkflowRecType.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowRecTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowRecTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.WorkflowRecType> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IWorkflowRecTypeModel> collection = provider.Other.WorkflowRecType.FetchAll();
            return collection.Select(model => new Consensus.Other.WorkflowRecType(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowRecTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowRecTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.WorkflowRecType FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return WorkflowRecType.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowRecTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowRecTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.WorkflowRecType FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IWorkflowRecTypeModel model = provider.Other.WorkflowRecType.FetchById(id);
            return model == null ? null : new Consensus.Other.WorkflowRecType(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return WorkflowRecType.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Other.WorkflowRecType.GetTableName();
        }

        #endregion
    }
}
