using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Encapsulates the <see cref="ReportPageRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportPageModel : LocalModel<ReportPageRecord, Int32>, IReportPageModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ReportModel" /> instances that reference this <see cref="ReportPageModel" />.
        /// </summary>
        private LocalCollection<LocalReportModel, IReportModel> _reportPages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportPageRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Reporting.ReportPage.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportPageRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Reporting.ReportPage.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportPageRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Reporting.ReportPage.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_NAME" field.
        /// </summary>
        public String PageName
        {
            get { return this.ModifiedData.PageName; }
            set { this.ModifiedData.PageName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_PATH" field.
        /// </summary>
        public String PagePath
        {
            get { return this.ModifiedData.PagePath; }
            set { this.ModifiedData.PagePath = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_SECTION" field.
        /// </summary>
        public String Section
        {
            get { return this.ModifiedData.Section; }
            set { this.ModifiedData.Section = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ReportModel" /> instances that reference this <see cref="ReportPageModel" />.
        /// </summary>
        public LocalCollection<LocalReportModel, IReportModel> ReportPages
        {
            get
            {
                if (_reportPages == null)
                    _reportPages = new LocalCollection<LocalReportModel, IReportModel>(this.Provider.Reporting.Report.FetchAllByReportPageId(this.Id));
                
                return _reportPages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalReportPageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalReportPageModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalReportPageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalReportPageModel(LocalProvider provider, ReportPageRecord record) : base(provider, record)
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
            if (_reportPages != null)
                _reportPages.Execute(obj => obj.ReportPageId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_NAME" field.
        /// </summary>
        System.String IReportPageModel.PageName
        {
            get { return this.PageName; }
            set { this.PageName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_PATH" field.
        /// </summary>
        System.String IReportPageModel.PagePath
        {
            get { return this.PagePath; }
            set { this.PagePath = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_SECTION" field.
        /// </summary>
        System.String IReportPageModel.Section
        {
            get { return this.Section; }
            set { this.Section = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ReportModel" /> instances that reference this <see cref="!:ReportPageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Reporting.IReportModel> IReportPageModel.ReportPages
        {
            get { return this.ReportPages; }
        }

        #endregion
    }
}
