using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Provides the definition for each type of search that is available within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchTypeModel : LocalModel<SystemSearchesRecord, Int32>, ISearchTypeModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="SearchColumnModel" /> instances that reference this <see cref="SearchTypeModel" />.
        /// </summary>
        private LocalCollection<LocalSearchColumnModel, ISearchColumnModel> _columns;

        /// <summary>
        ///     The collection of <see cref="SearchParameterModel" /> instances that reference this <see cref="SearchTypeModel" />.
        /// </summary>
        private LocalCollection<LocalSearchParameterModel, ISearchParameterModel> _parameters;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Search.SearchType.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Search.SearchType.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Search.SearchType.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_PAGE_TITLE" field.
        /// </summary>
        public String PageTitle
        {
            get { return this.ModifiedData.PageTitle; }
            set { this.ModifiedData.PageTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_DB_VIEW_NAME" field.
        /// </summary>
        public String DatabaseView
        {
            get { return this.ModifiedData.DbViewName; }
            set { this.ModifiedData.DbViewName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_NEW_BUTTON" field.
        /// </summary>
        public String NewButton
        {
            get { return this.ModifiedData.NewButton; }
            set { this.ModifiedData.NewButton = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_SAVE_JSON" field.
        /// </summary>
        public String SaveJson
        {
            get { return this.ModifiedData.SaveJson; }
            set { this.ModifiedData.SaveJson = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SearchColumnModel" /> instances that reference this <see cref="SearchTypeModel" />.
        /// </summary>
        public LocalCollection<LocalSearchColumnModel, ISearchColumnModel> Columns
        {
            get
            {
                if (_columns == null)
                    _columns = new LocalCollection<LocalSearchColumnModel, ISearchColumnModel>(this.Provider.Search.SearchColumn.FetchAllBySearchTypeId(this.Id));
                
                return _columns;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SearchParameterModel" /> instances that reference this <see cref="SearchTypeModel" />.
        /// </summary>
        public LocalCollection<LocalSearchParameterModel, ISearchParameterModel> Parameters
        {
            get
            {
                if (_parameters == null)
                    _parameters = new LocalCollection<LocalSearchParameterModel, ISearchParameterModel>(this.Provider.Search.SearchParameter.FetchAllBySearchTypeId(this.Id));
                
                return _parameters;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSearchTypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSearchTypeModel(LocalProvider provider, SystemSearchesRecord record) : base(provider, record)
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
            if (_columns != null)
                _columns.Execute(obj => obj.SearchTypeId = this.Id).Execute(obj => obj.Save());
            if (_parameters != null)
                _parameters.Execute(obj => obj.SearchTypeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "SYSS_TYPE" field.
        /// </summary>
        System.String ISearchTypeModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_PAGE_TITLE" field.
        /// </summary>
        System.String ISearchTypeModel.PageTitle
        {
            get { return this.PageTitle; }
            set { this.PageTitle = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_DB_VIEW_NAME" field.
        /// </summary>
        System.String ISearchTypeModel.DatabaseView
        {
            get { return this.DatabaseView; }
            set { this.DatabaseView = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_NEW_BUTTON" field.
        /// </summary>
        System.String ISearchTypeModel.NewButton
        {
            get { return this.NewButton; }
            set { this.NewButton = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_SAVE_JSON" field.
        /// </summary>
        System.String ISearchTypeModel.SaveJson
        {
            get { return this.SaveJson; }
            set { this.SaveJson = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SearchColumnModel" /> instances that reference this <see cref="!:SearchTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Search.ISearchColumnModel> ISearchTypeModel.Columns
        {
            get { return this.Columns; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SearchParameterModel" /> instances that reference this <see cref="!:SearchTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Search.ISearchParameterModel> ISearchTypeModel.Parameters
        {
            get { return this.Parameters; }
        }

        #endregion
    }
}
