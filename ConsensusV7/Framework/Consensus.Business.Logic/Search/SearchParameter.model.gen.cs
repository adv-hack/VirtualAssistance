using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Defines the parameters that are displayed and used to perform a search within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchParameterModel : LocalModel<SystemSearchesParameterFieldsRecord, Int32>, ISearchParameterModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        private LocalSearchTypeModel _searchType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesParameterFieldsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Search.SearchParameter.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesParameterFieldsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Search.SearchParameter.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesParameterFieldsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Search.SearchParameter.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        public LocalSearchTypeModel SearchType
        {
            get
            {
                if (_searchType == null)
                    _searchType = this.Provider.Search.SearchType.FetchById(this.SearchTypeId);
                if (_searchType == null)
                    _searchType = this.Provider.Search.SearchType.Create();
                
                return _searchType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        public Int32 SearchTypeId
        {
            get { return this.ModifiedData.SyssId; }
            set
            {
                if (this.ModifiedData.SyssId != value)
                     _searchType = null;
                this.ModifiedData.SyssId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DISPLAY_ORDER" field.
        /// </summary>
        public Int32 Order
        {
            get { return this.ModifiedData.DisplayOrder; }
            set { this.ModifiedData.DisplayOrder = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_NAME" field.
        /// </summary>
        public String FieldName
        {
            get { return this.ModifiedData.FieldName; }
            set { this.ModifiedData.FieldName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_LABEL" field.
        /// </summary>
        public String DefaultLabel
        {
            get { return this.ModifiedData.DefaultLabel; }
            set { this.ModifiedData.DefaultLabel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_LABEL" field.
        /// </summary>
        public String CustomLabel
        {
            get { return this.ModifiedData.Label; }
            set { this.ModifiedData.Label = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_TYPE" field.
        /// </summary>
        public String FieldType
        {
            get { return this.ModifiedData.FieldType; }
            set { this.ModifiedData.FieldType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OPERATOR" field.
        /// </summary>
        public String Condition
        {
            get { return this.ModifiedData.WhereClauseOperator; }
            set { this.ModifiedData.WhereClauseOperator = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_VALUE" field.
        /// </summary>
        public String DefaultValue
        {
            get { return this.ModifiedData.DefaultValue; }
            set { this.ModifiedData.DefaultValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_CODE_LIST" field.
        /// </summary>
        public String CodeType
        {
            get { return this.ModifiedData.CodeList; }
            set { this.ModifiedData.CodeList = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DATA" field.
        /// </summary>
        public String ListData
        {
            get { return this.ModifiedData.Data; }
            set { this.ModifiedData.Data = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OVERRIDE" field.
        /// </summary>
        public String ConditionSql
        {
            get { return this.ModifiedData.WhereClauseOverride; }
            set { this.ModifiedData.WhereClauseOverride = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchParameterModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSearchParameterModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchParameterModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSearchParameterModel(LocalProvider provider, SystemSearchesParameterFieldsRecord record) : base(provider, record)
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
            if (_searchType != null)
            {
                _searchType.Save();
                this.ModifiedData.SyssId = _searchType.Id;
            }
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
        ///     Gets the type of search parameter.
        /// </summary>
        Consensus.Search.SearchParameterTypes ISearchParameterModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_VISIBLE" field.
        /// </summary>
        System.Boolean ISearchParameterModel.Visible
        {
            get { return this.Visible; }
            set { this.Visible = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        Consensus.Search.ISearchTypeModel ISearchParameterModel.SearchType
        {
            get { return this.SearchType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        System.Int32 ISearchParameterModel.SearchTypeId
        {
            get { return this.SearchTypeId; }
            set { this.SearchTypeId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DISPLAY_ORDER" field.
        /// </summary>
        System.Int32 ISearchParameterModel.Order
        {
            get { return this.Order; }
            set { this.Order = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_NAME" field.
        /// </summary>
        System.String ISearchParameterModel.FieldName
        {
            get { return this.FieldName; }
            set { this.FieldName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_LABEL" field.
        /// </summary>
        System.String ISearchParameterModel.DefaultLabel
        {
            get { return this.DefaultLabel; }
            set { this.DefaultLabel = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_LABEL" field.
        /// </summary>
        System.String ISearchParameterModel.CustomLabel
        {
            get { return this.CustomLabel; }
            set { this.CustomLabel = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_TYPE" field.
        /// </summary>
        System.String ISearchParameterModel.FieldType
        {
            get { return this.FieldType; }
            set { this.FieldType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OPERATOR" field.
        /// </summary>
        System.String ISearchParameterModel.Condition
        {
            get { return this.Condition; }
            set { this.Condition = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_VALUE" field.
        /// </summary>
        System.String ISearchParameterModel.DefaultValue
        {
            get { return this.DefaultValue; }
            set { this.DefaultValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_CODE_LIST" field.
        /// </summary>
        System.String ISearchParameterModel.CodeType
        {
            get { return this.CodeType; }
            set { this.CodeType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DATA" field.
        /// </summary>
        System.String ISearchParameterModel.ListData
        {
            get { return this.ListData; }
            set { this.ListData = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OVERRIDE" field.
        /// </summary>
        System.String ISearchParameterModel.ConditionSql
        {
            get { return this.ConditionSql; }
            set { this.ConditionSql = (System.String)value; }
        }

        #endregion
    }
}
