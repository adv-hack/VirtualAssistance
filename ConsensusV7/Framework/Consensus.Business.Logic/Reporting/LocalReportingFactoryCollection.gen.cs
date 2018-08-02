using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Reporting namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportingFactoryCollection : LocalFactoryCollection, IReportingFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ReportModel" /> objects.
        /// </summary>
        private LocalReportFactory _report;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ReportPageModel" /> objects.
        /// </summary>
        private LocalReportPageFactory _reportPage;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ReportParamPageModel" /> objects.
        /// </summary>
        private LocalReportParamPageFactory _reportParamPage;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ReportModel" /> objects.
        /// </summary>
        public LocalReportFactory Report
        {
            get { return LocalFactory.Create(this.Provider, ref _report); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ReportPageModel" /> objects.
        /// </summary>
        public LocalReportPageFactory ReportPage
        {
            get { return LocalFactory.Create(this.Provider, ref _reportPage); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ReportParamPageModel" /> objects.
        /// </summary>
        public LocalReportParamPageFactory ReportParamPage
        {
            get { return LocalFactory.Create(this.Provider, ref _reportParamPage); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ReportModel" /> objects.
        /// </summary>
        Consensus.Reporting.IReportFactory IReportingFactoryCollection.Report
        {
            get { return this.Report; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ReportPageModel" /> objects.
        /// </summary>
        Consensus.Reporting.IReportPageFactory IReportingFactoryCollection.ReportPage
        {
            get { return this.ReportPage; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ReportParamPageModel" /> objects.
        /// </summary>
        Consensus.Reporting.IReportParamPageFactory IReportingFactoryCollection.ReportParamPage
        {
            get { return this.ReportParamPage; }
        }

        #endregion
    }
}
