using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Encapsulates the <see cref="ReportParampageRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportParamPageModel : LocalModel<ReportParampageRecord, Int32>, IReportParamPageModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ReportModel" /> instances that reference this <see cref="ReportParamPageModel" />.
        /// </summary>
        private LocalCollection<LocalReportModel, IReportModel> _reportParamPages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportParampageRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Reporting.ReportParamPage.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportParampageRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Reporting.ReportParamPage.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportParampageRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Reporting.ReportParamPage.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_NAME" field.
        /// </summary>
        public String PageName
        {
            get { return this.ModifiedData.PageName; }
            set { this.ModifiedData.PageName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_PATH" field.
        /// </summary>
        public String PagePath
        {
            get { return this.ModifiedData.PagePath; }
            set { this.ModifiedData.PagePath = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PARAM_DESC" field.
        /// </summary>
        public String ParamDesc
        {
            get { return this.ModifiedData.ParamDesc; }
            set { this.ModifiedData.ParamDesc = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ReportModel" /> instances that reference this <see cref="ReportParamPageModel" />.
        /// </summary>
        public LocalCollection<LocalReportModel, IReportModel> ReportParamPages
        {
            get
            {
                if (_reportParamPages == null)
                    _reportParamPages = new LocalCollection<LocalReportModel, IReportModel>(this.Provider.Reporting.Report.FetchAllByReportParamPageId(this.Id));
                
                return _reportParamPages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalReportParamPageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalReportParamPageModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalReportParamPageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalReportParamPageModel(LocalProvider provider, ReportParampageRecord record) : base(provider, record)
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
            if (_reportParamPages != null)
                _reportParamPages.Execute(obj => obj.ReportParamPageId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_NAME" field.
        /// </summary>
        System.String IReportParamPageModel.PageName
        {
            get { return this.PageName; }
            set { this.PageName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_PATH" field.
        /// </summary>
        System.String IReportParamPageModel.PagePath
        {
            get { return this.PagePath; }
            set { this.PagePath = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PARAM_DESC" field.
        /// </summary>
        System.String IReportParamPageModel.ParamDesc
        {
            get { return this.ParamDesc; }
            set { this.ParamDesc = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ReportModel" /> instances that reference this <see cref="!:ReportParamPageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Reporting.IReportModel> IReportParamPageModel.ReportParamPages
        {
            get { return this.ReportParamPages; }
        }

        #endregion
    }
}
