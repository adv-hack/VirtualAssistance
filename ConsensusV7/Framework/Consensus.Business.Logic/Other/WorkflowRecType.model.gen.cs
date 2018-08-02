using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="WorkflowRecTypeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalWorkflowRecTypeModel : LocalModel<WorkflowRecTypeRecord, String>, IWorkflowRecTypeModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<WorkflowRecTypeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Other.WorkflowRecType.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<WorkflowRecTypeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Other.WorkflowRecType.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<WorkflowRecTypeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Other.WorkflowRecType.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_REC_TYPE" field.
        /// </summary>
        public String RecType
        {
            get { return this.ModifiedData.RecType; }
            set { this.ModifiedData.RecType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE" field.
        /// </summary>
        public String Table
        {
            get { return this.ModifiedData.Table; }
            set { this.ModifiedData.Table = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE_KEY" field.
        /// </summary>
        public String TableKey
        {
            get { return this.ModifiedData.TableKey; }
            set { this.ModifiedData.TableKey = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SQL" field.
        /// </summary>
        public String Sql
        {
            get { return this.ModifiedData.Sql; }
            set { this.ModifiedData.Sql = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE" field.
        /// </summary>
        public String PrType
        {
            get { return this.ModifiedData.PrType; }
            set { this.ModifiedData.PrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SEARCH_ENTITY" field.
        /// </summary>
        public String SearchEntity
        {
            get { return this.ModifiedData.SearchEntity; }
            set { this.ModifiedData.SearchEntity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_LINK_TO" field.
        /// </summary>
        public String LinkTo
        {
            get { return this.ModifiedData.LinkTo; }
            set { this.ModifiedData.LinkTo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE_TYPE" field.
        /// </summary>
        public String PrTypeType
        {
            get { return this.ModifiedData.PrTypeType; }
            set { this.ModifiedData.PrTypeType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY" field.
        /// </summary>
        public Byte? Query
        {
            get { return this.ModifiedData.Query; }
            set { this.ModifiedData.Query = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_SELECT" field.
        /// </summary>
        public String QuerySelect
        {
            get { return this.ModifiedData.QuerySelect; }
            set { this.ModifiedData.QuerySelect = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_MERGE" field.
        /// </summary>
        public String QueryMerge
        {
            get { return this.ModifiedData.QueryMerge; }
            set { this.ModifiedData.QueryMerge = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_ACT_TYPES" field.
        /// </summary>
        public String ActTypes
        {
            get { return this.ModifiedData.ActTypes; }
            set { this.ModifiedData.ActTypes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_ARG" field.
        /// </summary>
        public Byte PrArg
        {
            get { return this.ModifiedData.PrArg; }
            set { this.ModifiedData.PrArg = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalWorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalWorkflowRecTypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalWorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalWorkflowRecTypeModel(LocalProvider provider, WorkflowRecTypeRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "WRT_REC_TYPE" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.RecType
        {
            get { return this.RecType; }
            set { this.RecType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_DESC" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.Table
        {
            get { return this.Table; }
            set { this.Table = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE_KEY" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.TableKey
        {
            get { return this.TableKey; }
            set { this.TableKey = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SQL" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.Sql
        {
            get { return this.Sql; }
            set { this.Sql = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.PrType
        {
            get { return this.PrType; }
            set { this.PrType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SEARCH_ENTITY" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.SearchEntity
        {
            get { return this.SearchEntity; }
            set { this.SearchEntity = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_LINK_TO" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.LinkTo
        {
            get { return this.LinkTo; }
            set { this.LinkTo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE_TYPE" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.PrTypeType
        {
            get { return this.PrTypeType; }
            set { this.PrTypeType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY" field.
        /// </summary>
        System.Nullable<System.Byte> IWorkflowRecTypeModel.Query
        {
            get { return this.Query; }
            set { this.Query = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_SELECT" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.QuerySelect
        {
            get { return this.QuerySelect; }
            set { this.QuerySelect = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_MERGE" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.QueryMerge
        {
            get { return this.QueryMerge; }
            set { this.QueryMerge = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_ACT_TYPES" field.
        /// </summary>
        System.String IWorkflowRecTypeModel.ActTypes
        {
            get { return this.ActTypes; }
            set { this.ActTypes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_ARG" field.
        /// </summary>
        System.Byte IWorkflowRecTypeModel.PrArg
        {
            get { return this.PrArg; }
            set { this.PrArg = (System.Byte)value; }
        }

        #endregion
    }
}
